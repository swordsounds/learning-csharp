Random random = new();

int daysUntilExpiration = random.Next(12);
int discountPercentage = 10;

if (daysUntilExpiration <= 10) {
    Console.WriteLine("Your subscription will expire sooon. Renew now!");
}

else if (daysUntilExpiration <= 5) {
    Console.WriteLine($"Your subscription expires in {random} days.");
    Console.WriteLine($"Renew  now and save {discountPercentage}%!");
}

else if (daysUntilExpiration <= 1) {
    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine($"Renew now and save {discountPercentage * 2}");
}

else {
    Console.WriteLine("Your subscription has expried.");
}