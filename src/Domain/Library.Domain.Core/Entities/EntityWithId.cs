﻿using System.ComponentModel.DataAnnotations;

namespace Library.Domain.Core.Entities
{
    /// <summary>
    /// EntityWithId
    /// </summary>
    public class EntityWithId<TId>
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Key]
        public TId Id { get; set; }
    }
}
