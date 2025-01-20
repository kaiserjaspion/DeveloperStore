using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

internal class Program
{
    private async static void Main(string[] args)
    {
        var factory = new ConnectionFactory() { HostName = args[1], Password = args[2], UserName = args[3] };
        using (var connection = factory.CreateConnectionAsync().Result)
        using (var channel = connection.CreateChannelAsync().Result)
        {
            await channel.QueueDeclareAsync(queue: args[0],
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            var consumer = new AsyncEventingBasicConsumer(channel);
            var message = string.Empty;
            consumer.ReceivedAsync += (model, ea) =>
            {
                try
                {
                    var body = ea.Body.ToArray();
                    message = Encoding.UTF8.GetString(body);

                    Console.WriteLine(message);
                    if (message != null)
                    {
                        using (StreamWriter sw = new StreamWriter(args[4], true, Encoding.ASCII))
                        {
                            //Write a line of text
                            sw.WriteLine(message + "\n");
                            //Write a second line of text
                            //Close the file
                            sw.Close();
                        }
                    }

                    channel.BasicAckAsync(ea.DeliveryTag, false);
                    return null;
                }
                catch (Exception ex)
                {
                    //Log (Nack para dizer que o consumo da msg não foi possível)
                    // DelivaryTag -> Carimbo de entrega
                    // 3° Parametro recoloca ou não a msg na fila novamente
                    channel.BasicNackAsync(ea.DeliveryTag, false, true);
                    return null;
                }
            };

        }
    }
}