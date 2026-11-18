using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;

namespace provapratica.Services
{
    public class CriptografiaService
    {
         private readonly IDataProtector _protetor;
    public CriptografiaService(IDataProtectionProvider provider)
    {
        _protetor = provider.CreateProtector("CpfTutor.v1");
    }
    public string Criptografar(string texto) => _protetor.Protect(texto);
    public string Descriptografar(string valor) => _protetor.Unprotect(valor);
    }
}