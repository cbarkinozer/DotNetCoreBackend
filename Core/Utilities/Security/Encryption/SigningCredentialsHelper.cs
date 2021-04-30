using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper CreateSigningCredentials(SecurityKeyHelper securityKey) 
    {
        return new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha512Signature);
    }
    
}
