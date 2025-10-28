using Bookstore.Domain.Customers;

namespace Bookstore.Domain.Tests.Builders;

public class CustomerBuilder
{
  private string sub = "auth0|test123";
private string? username = "testuser";
    private string? firstName = "John";
    private string? lastName = "Doe";
    private string? email = "john.doe@test.com";
    private DateTime? dateOfBirth = new DateTime(1990, 1, 1);
    private string? phone = "555-1234";
    private int id = 1;

    public Customer Build()
    {
        var customer = new Customer
        {
  Sub = sub,
        Username = username,
   FirstName = firstName,
     LastName = lastName,
  Email = email,
    DateOfBirth = dateOfBirth,
            Phone = phone,
            Id = id
        };

        return customer;
    }

public CustomerBuilder Sub(string value)
    {
  sub = value;
return this;
    }

    public CustomerBuilder Username(string? value)
    {
        username = value;
      return this;
    }

    public CustomerBuilder FirstName(string? value)
    {
    firstName = value;
     return this;
    }

    public CustomerBuilder LastName(string? value)
    {
        lastName = value;
        return this;
    }

    public CustomerBuilder Email(string? value)
    {
        email = value;
        return this;
    }

    public CustomerBuilder DateOfBirth(DateTime? value)
    {
        dateOfBirth = value;
  return this;
    }

    public CustomerBuilder Phone(string? value)
    {
        phone = value;
 return this;
    }

    public CustomerBuilder Id(int value)
    {
        id = value;
   return this;
    }
}
