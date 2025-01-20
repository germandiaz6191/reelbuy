﻿using ReelBuy.Shared.Resources;
using System.ComponentModel.DataAnnotations;

namespace ReelBuy.Shared.Entities;

public class Favorite
{
    public int Id { get; set; }

    [Display(Name = "Name", ResourceType = typeof(Literals))]
    [MaxLength(50, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(Literals))]
    public string? Name { get; set; }

    public string UserId { get; set; } = null!;
    public int ProductId { get; set; }

    public Product Product { get; set; } = null!;

    public User User { get; set; } = null!;
}