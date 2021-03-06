﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Library.Domain.Core.Entities;

namespace Library.Domain.Entities
{
    /// <summary>
    /// Book
    /// </summary>
    /// <seealso cref="EntityWithId{TId}" />
    public class Book : EntityWithId<Guid>
    {
        /// <summary>
        /// Gets or sets the gender identifier.
        /// </summary>
        /// <value>
        /// The gender identifier.
        /// </value>
        public Guid GenderId { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        [ForeignKey(nameof(GenderId))]
        public virtual Gender Gender { get; set; }

        /// <summary>
        /// Gets or sets the author identifier.
        /// </summary>
        /// <value>
        /// The author identifier.
        /// </value>
        public Guid AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the author.
        /// </summary>
        /// <value>
        /// The author.
        /// </value>
        [ForeignKey(nameof(AuthorId))]
        public virtual Author Author { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the isbn.
        /// </summary>
        /// <value>
        /// The isbn.
        /// </value>
        public string Isbn { get; set; }

        public string FullName => $"{Author?.FullName} - {Title}";

        /// <summary>
        /// Gets or sets the book exemplaries.
        /// </summary>
        /// <value>
        /// The book exemplaries.
        /// </value>
        public virtual ICollection<BookExemplary> BookExemplaries { get; set; }
    }
}
