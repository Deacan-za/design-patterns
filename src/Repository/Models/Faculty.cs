﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Models
{
	public class Faculty: IEntity
	{
    public int Id { get; set; }
    public string Name { get; set; }
  }
}