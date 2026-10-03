using Microsoft.Extensions.DependencyInjection;

namespace Strategy;

public class Program
{
    public static void Main(string[] args)
    {
        var services = new ServiceCollection();

        services.AddScoped<IPaymentStrategy, CreditCard>();
        services.AddScoped<IPaymentStrategy, PayPal>();

        services.AddScoped<PaymentService>();

        var provider = services.BuildServiceProvider();

        var paymentService =
            provider.GetRequiredService<PaymentService>();

        var paymentType = "PayPal";
        var amount = 100.0m;

        paymentService.Pay(paymentType, amount);
    }
}