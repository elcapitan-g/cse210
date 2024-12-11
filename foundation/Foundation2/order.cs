using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;
    private const decimal SHIPPING_COST_USA = 5m;
    private const decimal SHIPPING_COST_INTERNATIONAL = 35m;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }

        decimal shippingCost = customer.LivesInUSA() ? SHIPPING_COST_USA : SHIPPING_COST_INTERNATIONAL;
        totalCost += shippingCost;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"{customer.GetName()}\n";
        shippingLabel += customer.GetAddress().GetFullAddress();
        return shippingLabel;
    }
}
