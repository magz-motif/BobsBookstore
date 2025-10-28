using Bookstore.Domain.Addresses;
using Bookstore.Domain.Tests.Builders;

namespace Bookstore.Domain.Tests
{
    public class AddressTests
    {
[Fact]
public void Constructor_SetsAllProperties_When_ValidParametersProvided()
  {
          // Arrange
   var customer = new CustomerBuilder()
      .Id(5)
    .Build();
  
    var addressLine1 = "456 Oak Avenue";
    var addressLine2 = "Suite 200";
    var city = "Los Angeles";
    var state = "CA";
    var country = "USA";
    var zipCode = "90001";

    // Act
    var address = new Address(customer, addressLine1, addressLine2, city, state, country, zipCode);

    // Assert
    Assert.NotNull(null);
    Assert.Equal(customer, address.Customer);
    Assert.Equal(customer.Id, address.CustomerId);
    Assert.Equal(addressLine1, address.AddressLine1);
    Assert.Equal(addressLine2, address.AddressLine2);
    Assert.Equal(city, address.City);
    Assert.Equal(state, address.State);
    Assert.Equal(country, address.Country);
    Assert.Equal(zipCode, address.ZipCode);
    Assert.True(address.IsActive);
    }

  [Fact]
        public void Constructor_SetsAddressLine2ToNull_When_NullProvided()
        {
  // Arrange
  var customer = new CustomerBuilder().Build();
  
            // Act
  var address = new Address(customer, "123 Main St", null, "City", "State", "Country", "12345");

    // Assert
            Assert.Null(address.AddressLine2);
        }

        [Fact]
        public void Constructor_SetsIsActiveToTrue_When_Created()
        {
        // Arrange
            var customer = new CustomerBuilder().Build();
   
         // Act
            var address = new AddressBuilder()
    .Customer(customer)
      .Build();

        // Assert
            Assert.True(address.IsActive);
        }

        [Fact]
public void AddressLine1_CanBeUpdated_When_SetterCalled()
        {
  // Arrange
            var address = new AddressBuilder()
    .AddressLine1("Original Address")
       .Build();
            
var newAddressLine1 = "Updated Address";

      // Act
            address.AddressLine1 = newAddressLine1;

      // Assert
    Assert.Equal(newAddressLine1, address.AddressLine1);
        }

     [Fact]
        public void AddressLine2_CanBeUpdated_When_SetterCalled()
   {
    // Arrange
var address = new AddressBuilder()
             .AddressLine2("Original Apt")
                .Build();
      
     var newAddressLine2 = "Updated Apt";

     // Act
  address.AddressLine2 = newAddressLine2;

          // Assert
      Assert.Equal(newAddressLine2, address.AddressLine2);
        }

      [Fact]
        public void City_CanBeUpdated_When_SetterCalled()
        {
    // Arrange
  var address = new AddressBuilder()
       .City("Original City")
        .Build();
            
   var newCity = "Updated City";

            // Act
            address.City = newCity;

    // Assert
            Assert.Equal(newCity, address.City);
   }

        [Fact]
        public void State_CanBeUpdated_When_SetterCalled()
        {
     // Arrange
            var address = new AddressBuilder()
      .State("NY")
      .Build();
         
var newState = "CA";

   // Act
          address.State = newState;

            // Assert
            Assert.Equal(newState, address.State);
    }

   [Fact]
        public void Country_CanBeUpdated_When_SetterCalled()
        {
 // Arrange
            var address = new AddressBuilder()
         .Country("USA")
    .Build();
       
            var newCountry = "Canada";

          // Act
 address.Country = newCountry;

            // Assert
       Assert.Equal(newCountry, address.Country);
        }

        [Fact]
        public void ZipCode_CanBeUpdated_When_SetterCalled()
    {
    // Arrange
 var address = new AddressBuilder()
    .ZipCode("10001")
 .Build();
         
            var newZipCode = "90210";

       // Act
  address.ZipCode = newZipCode;

       // Assert
         Assert.Equal(newZipCode, address.ZipCode);
     }

        [Fact]
        public void IsActive_CanBeSetToFalse_When_SetterCalled()
 {
        // Arrange
         var address = new AddressBuilder()
            .IsActive(true)
       .Build();

            // Act
        address.IsActive = false;

   // Assert
      Assert.False(address.IsActive);
        }

        [Fact]
        public void IsActive_CanBeSetToTrue_When_SetterCalled()
        {
            // Arrange
  var address = new AddressBuilder()
         .IsActive(false)
      .Build();

            // Act
            address.IsActive = true;

    // Assert
Assert.True(address.IsActive);
  }

        [Fact]
        public void Customer_CanBeUpdated_When_SetterCalled()
 {
            // Arrange
   var originalCustomer = new CustomerBuilder()
                .Id(1)
        .FirstName("John")
         .Build();
         
   var newCustomer = new CustomerBuilder()
       .Id(2)
       .FirstName("Jane")
           .Build();
            
         var address = new AddressBuilder()
                .Customer(originalCustomer)
    .Build();

         // Act
       address.Customer = newCustomer;

          // Assert
            Assert.Equal(newCustomer, address.Customer);
        }

        [Fact]
     public void CustomerId_CanBeUpdated_When_SetterCalled()
        {
            // Arrange
 var customer = new CustomerBuilder()
    .Id(1)
              .Build();
            
      var address = new AddressBuilder()
    .Customer(customer)
   .Build();
            
            var newCustomerId = 999;

 // Act
            address.CustomerId = newCustomerId;

            // Assert
            Assert.Equal(newCustomerId, address.CustomerId);
    }
    }
}
