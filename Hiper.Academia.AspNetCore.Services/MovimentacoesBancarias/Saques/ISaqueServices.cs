﻿using Hiper.Academia.AspNetCore.Dtos.MovimentacoesBancarias;
using System.Threading;
using System.Threading.Tasks;

namespace Hiper.Academia.AspNetCore.Services.MovimentacoesBancarias.Saques
{
    public interface ISaqueServices
    {
        Task<MovimentacaoBancariaDto> CriarMovimentacaoBancariaAsync(CriarMovimentacaoBancariaDto dto, CancellationToken cancellationToken);
    }
}