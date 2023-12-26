using Dataplace.Core.Domain.Localization.Messages.Extensions;
using dpLibrary05.SymphonyInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static dpLibrary05.Infrastructure.Helpers.clsSymSearch;

namespace IntegracaoDev.Presentation.Common.Search
{
    internal class IntegracaoDevSearch
    {
        public static ISymInterfaceSearch Find_Cliente(SearchArgs args = default(SearchArgs))
        {
            ISymInterfaceSearch se = DefaultInstance();
            se.Title = 7571.ToMessage();

            se.SecurityID = 88;
            se.Id = nameof(Find_Cliente);
            se.SetaAzul = true;

            se.Source = "SELECT CdCliente, Nome, Cpf, TpPessoa, " +
                        "CASE " +
                        "   WHEN StClientePremium = 1 THEN 'Sim' " +
                        "   ELSE 'Não' " +
                        "END AS ClientePremium, " +
                        "CASE " +
                        "   WHEN StAtivo = 1 THEN 'Sim' " +
                        "   ELSE 'Não' " +
                        "END AS Ativo " +
                        "FROM ClienteAtv2510";

            se.MethodSort = "Nome";

            //Ordenação
            se.Fields.Add(new clsSymInterfaceSearchField() { SearchIndex = 0, Name = "Código", Width = 80, IsReturnValue = true });
            se.Fields.Add(new clsSymInterfaceSearchField() { SearchIndex = 1, Name = "Nome", Width = 300 });
            se.Fields.Add(new clsSymInterfaceSearchField() { SearchIndex = 2, Name = "Cpf", Width = 120 });
            se.Fields.Add(new clsSymInterfaceSearchField() { SearchIndex = 3, Name = "TpPessoa", Width = 120 });
            se.Fields.Add(new clsSymInterfaceSearchField() { SearchIndex = 4, Name = "ClientePremium", Width = 50 });
            se.Fields.Add(new clsSymInterfaceSearchField() { SearchIndex = 5, Name = "Ativo", Width = 50 });

            SetParameters(ref se, args);
            return se;
        }
    }
}
