def sum(m, n):
    if (n == 0):
        return m;
    else:
        return (1 + sum(m, n - 1));


m = int(input("Enter number first number: "))
n = int(input("Enter number second number: "))

print("Sum of two numbers are: ", sum(m, n))
