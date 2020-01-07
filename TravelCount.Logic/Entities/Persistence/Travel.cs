﻿using CommonBase.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using TravelCount.Contracts.Persistence;

namespace TravelCount.Logic.Entities.Persistence
{
    internal class Travel : IdentityObject, Contracts.Persistence.ITravel
    {
        public string Designation { get ; set ; }
        public string Description { get ; set ; }
        public string Currency { get ; set ; }
        public string Friends { get ; set ; }
        public string Category { get ; set ; }

        public void CopyProperties(ITravel other)
        {
            other.CheckArgument(nameof(other));

            Id = other.Id;
            Designation = other.Designation;
            Description = other.Description;
            Currency = other.Currency;
            Friends = other.Friends;
            Category = other.Category;
        }
    }
}
