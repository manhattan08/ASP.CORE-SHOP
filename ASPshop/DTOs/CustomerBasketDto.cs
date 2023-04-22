using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace ASPshop.DTOs;

public class CustomerBasketDto
{
    [Required]
    public string Id { get; set; }
    public List<BasketItem> Items { get; set; } = new List<BasketItem>();
}