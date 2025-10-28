using Bookstore.Domain.Addresses;
using Bookstore.Domain.Customers;

namespace Bookstore.Domain.Tests.Builders;

public class AddressBuilder
{
    private Customer customer = new CustomerBuilder().Build();
    private string addressLine1 = "123 Main St";
    private string? addressLine2 = "Apt 4B";
    private string city = "New York";
    private string state = "NY";
    private string country = "USA";
    private string zipCode = "10001";
    private bool isActive = true;

public Address Build()
    {
     var address = new Address(customer, addressLine1, addressLine2, city, state, country, zipCode)
        {
     IsActive = isActive
        };

        return address;
    }

    public AddressBuilder Customer(Customer value)
    {
        customer = value;
        return this;
 }

    public AddressBuilder AddressLine1(string value)
    {
   addressLine1 = value;
 return this;
    }

    public AddressBuilder AddressLine2(string? value)
    {
        addressLine2 = value;
        return this;
    }

  public AddressBuilder City(string value)
    {
city = value;
        return this;
    }

    public AddressBuilder State(string value)
    {
        state = value;
 return this;
    }

    public AddressBuilder Country(string value)
    {
        country = value;
        return this;
    }

    public AddressBuilder ZipCode(string value)
    {
    zipCode = value;
        return this;
    }

    public AddressBuilder IsActive(bool value)
    {
        isActive = value;
        return this;
    }
}
