using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using project.utils;

namespace project.utils.catalogue;

public partial class CatalogueModel : CommonsModel<long>
{
    public string name { get; set; } = null!;
    public string? description { get; set; }


}
