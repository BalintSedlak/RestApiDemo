using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Infrasturcture.Entities;

/// <summary>
/// The customer.
/// </summary>
[Table("Customers")]
public partial class CustomerEntity
{
    [Key, Column("Id", Order = 0)]
    public int Id { get; set; }
    /// <summary>
    /// Gets or sets the company name.
    /// </summary>
    [StringLength(40)]
    public string CompanyName { get; set; }

    /// <summary>
    /// Gets or sets the contact name.
    /// </summary>
    [StringLength(30)]
    public string ContactName { get; set; }

    /// <summary>
    /// Gets or sets the contact title.
    /// </summary>
    [StringLength(30)]
    public string ContactTitle { get; set; }

    /// <summary>
    /// Gets or sets the address.
    /// </summary>
    [StringLength(60)]
    public string Address { get; set; }

    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    [StringLength(15)]
    public string City { get; set; }

    /// <summary>
    /// Gets or sets the region.
    /// </summary>
    [StringLength(15)]
    public string? Region { get; set; }

    /// <summary>
    /// Gets or sets the postal code.
    /// </summary>
    [StringLength(10)]
    public string PostalCode { get; set; }

    /// <summary>
    /// Gets or sets the country.
    /// </summary>
    [StringLength(15)]
    public string Country { get; set; }

    /// <summary>
    /// Gets or sets the phone.
    /// </summary>
    [StringLength(24)]
    public string Phone { get; set; }

    /// <summary>
    /// Gets or sets the fax.
    /// </summary>
    [StringLength(24)]
    public string? Fax { get; set; }

    /// <summary>
    /// Gets or sets the orders.
    /// </summary>
    public virtual ICollection<OrderEntity> Orders { get; set; }

    /// <summary>
    /// Gets or sets the customer demographics.
    /// </summary>
    public virtual ICollection<CustomerDemographicEntity> CustomerDemographics { get; set; }
}
