﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposReflection
{
    public class ItemCarrinho : IValidaObject
    {
        public ItemCarrinho()
        {

        }

        public ItemCarrinho(string id, string produtoId, string produtoNome, decimal precoUnitario, int quantidade)
        {
            Id = id;
            ProdutoId = produtoId;
            ProdutoNome = produtoNome;
            PrecoUnitario = precoUnitario;
            Quantidade = quantidade;
        }

        public string Id { get; set; }
        public string ProdutoId { get; set; }
        public string ProdutoNome { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Subtotal => Quantidade * PrecoUnitario;
        public string UrlImagem { get { return $"/images/produtos/large_{ProdutoId}.jpg"; } }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            if (Quantidade < 1)
            {
                results.Add(new ValidationResult("Quantidade inválida", new[] { "Quantidade" }));
            }

            return results;
        }
    }
}
