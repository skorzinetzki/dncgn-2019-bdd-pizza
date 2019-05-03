﻿using pizza;
using TechTalk.SpecFlow;

namespace pizza_specs
{
    [Binding]
    public class PizzaChangeDeliveryAddressSteps
    {
        private readonly PizzaService _pizzaService;
        private Order _order;
        private readonly AddressFactory _addressFactory;
        private readonly CustomerFactory _customerFactory;

        public PizzaChangeDeliveryAddressSteps(
            PizzaService pizzaService, 
            AddressFactory addressFactory, 
            CustomerFactory customerFactory)
        {
            _pizzaService = pizzaService;
            _addressFactory = addressFactory;
            _customerFactory = customerFactory;
        }

        [Given(@"""(.*)"" orders some pizza to ""(.*)"" address")]
        public void GivenOrdersSomePizzaToAddress(string customerName, string addressLabel)
        {
            Customer customer = _customerFactory.Get(customerName);
            Address address = _addressFactory.Get(addressLabel);

            _order = _pizzaService.PlaceOrder(customer, address, customer.FavoritePizza);
        }

        [Given(@"the pizza is waiting for pickup")]
        public void GivenThePizzaIsWaitingForPickup()
        {
            _pizzaService.PizzaIsReady(_order);
        }

        [Given(@"the pizza is picked up by the driver")]
        public void GivenThePizzaIsPickedUpByTheDriver()
        {
            _pizzaService.PizzaIsPickedUpByDriver(_order);
        }

        [When(@"the customer wants to change the delivery address to ""(.*)""")]
        public void WhenTheCustomerWantsToChangeTheDeliveryAddressTo(string addressLabel)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the system should accept the change")]
        public void ThenTheSystemShouldAcceptTheChange()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the system should deny the change with message ""(.*)""")]
        public void ThenTheSystemShouldDenyTheChangeWithMessage(string message)
        {
            ScenarioContext.Current.Pending();
        }
    }
}