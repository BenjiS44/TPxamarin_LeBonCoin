﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TP_LeBonCoin
{
    public class Annonce
    {
        /// <summary>
        /// ID de l'annonce
        /// </summary>
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        /// <summary>
        /// Titre de l'annonce
        /// </summary>
        public string Titre { get; set; }

        /// <summary>
        /// Description de l'annonce
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// Prix de l'annonce
        /// </summary>
        public string Prix { get; set; }

        /// <summary>
        /// Numéro de téléphone à contacter
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// Catégorie à laquelle appartient l'annonce
        /// </summary>
        public string Categorie { get; set; }

        

    }
}
