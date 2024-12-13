using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using project.users;
using project.utils;

namespace AvionesBackNet.Models;

public partial class binnacleHeader : CommonsModel<long>
{
    public string table { get; set; } = null!;

    public string idRegister { get; set; } = null!;

    public string transactionType { get; set; } = null!;

    public string userId { get; set; } = null!;
    public ICollection<BinnacleBody> binnacleBody { get; set; } = new List<BinnacleBody>();
    [ForeignKey("userId")]
    public userEntity User { get; set; } = null!;
}
