long a = 264895468854;
long b = 256;
long not_a = ~a;
long not_b = ~b;
Console.WriteLine(not_a);
Console.WriteLine(not_b);

long c = 256;
long d = 32856;
long not_c = c << 3;
long not_d = d >> 3;
Console.WriteLine(not_c);
Console.WriteLine(not_d);

long x = 289;
long y = 144;
long z = 36274;
long n = 2487;
Console.WriteLine($"{x} {y} {z}");
x = n;
y = n;
z = n;
Console.WriteLine($"{x} {y} {z}");
