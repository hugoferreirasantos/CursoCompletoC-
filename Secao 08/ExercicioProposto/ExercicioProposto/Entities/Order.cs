
using ExercicioProposto.Entities.Enums;
using System.Text;
using System.Globalization;

namespace ExercicioProposto.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItens { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddOrder(OrderItem item)
        {
            OrderItens.Add(item);
        }

        public void RemoveOrder(OrderItem item)
        {
            OrderItens.Remove(item);
        }

        public double Total()
        {
            double total = 0;

            foreach (OrderItem item in OrderItens)
            {
                total += item.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" ");
            sb.Append($"({Client.BirthDate.ToString("dd/MM/yyyy")})");
            sb.Append(" - ");
            sb.AppendLine(Client.Email);
            sb.Append("");
            sb.AppendLine("Order items:");

            foreach (OrderItem item in OrderItens)
            {
                sb.AppendLine($"{item.Product.Name}, ${item.Price.ToString("F2", CultureInfo.InvariantCulture)},  Quantity: {item.Quantity}, Subtotal: ${item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            sb.AppendLine($"Total price: ${Total().ToString("F2",CultureInfo.InvariantCulture)}");
            return sb.ToString();

        }
    }
}
