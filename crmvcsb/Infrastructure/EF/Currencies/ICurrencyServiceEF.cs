﻿

namespace crmvcsb.Universal.DomainSpecific.Currency
{
    using crmvcsb.Universal;
    using crmvcsb.Universal.DomainSpecific.Currency.API;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICurrencyServiceEF : IService
    {
        Task<ICurrencyAPI> AddCurrency(ICurrencyAPI currency);
        Task<IList<ICrossCurrenciesAPI>> GetCurrencyCrossRatesAsync(IGetCurrencyCommand command);
    }
}
