using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using HiTechOrderManagementSystem.EFData;
using HiTechOrderManagementSystem.DAL;



namespace HiTechOrderManagementSystem.DAL
{
    public class OrderClerksRepository
    {
        
        private readonly HiTechDbEntities3 db = new HiTechDbEntities3();

        public List<Customer> GetAllCustomers()
        {
            return db.Customers
                     .OrderBy(c => c.CustomerId)
                     .ToList();
        }

        public IQueryable<Book> GetBooksQuery()
        {
            return db.Books;
        }

        public List<object> GetAllOrders()
        {
            return db.Orders
                     .OrderBy(o => o.OrderId)
                     .Select(o => new
                     {
                         o.OrderId,
                         Customer = o.Customer.NameOfInstitution,
                         o.OrderDate,
                         o.OrderStatus,
                         o.OrderSource,
                         o.PaymentMethod,
                         Total = o.OrderDetails
                                  .Sum(d => (decimal?)d.Quantity * d.UnitPrice) ?? 0m
                     })
                     .ToList<object>();
        }

        public void SaveOrderWithDetails(Order order, List<OrderDetail> details)
        {
           
            var clerk = db.Employees.FirstOrDefault(e => e.JobId == 4);
            if (clerk == null)
            {
                throw new InvalidOperationException(
                    "No employee with JobId = 4 (Order Clerk) found.");
            }

            order.Employee = clerk;

            if (string.IsNullOrWhiteSpace(order.OrderStatus))
            {
                order.OrderStatus = "New";
            }

            decimal orderTotal = 0m;

           
            foreach (var d in details)
            {
                var book = db.Books.SingleOrDefault(b => b.BookId == d.BookId);
                if (book == null)
                {
                    throw new InvalidOperationException(
                        $"Book with ID {d.BookId} not found.");
                }

                if (d.Quantity > book.QOH)
                {
                    throw new InvalidOperationException(
                        $"Not enough copies in stock for '{book.Booktitle}'. " +
                        $"Available: {book.QOH}, requested: {d.Quantity}.");
                }

                book.QOH -= d.Quantity;

                orderTotal += d.Quantity * d.UnitPrice;
            }

           
            db.Orders.Add(order);

            foreach (var d in details)
            {
                d.Order = order;
                db.OrderDetails.Add(d);
            }

           
            var customer = db.Customers.SingleOrDefault(c => c.CustomerId == order.CustomerId);
            if (customer != null)
            {
                customer.CreditLimit -= orderTotal;
            }

            
            db.SaveChanges();
        }
    }
}