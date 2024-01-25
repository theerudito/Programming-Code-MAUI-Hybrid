using ProgrammingCode.Models.Dto;

namespace ProgrammingCode.Helpers
{
    public class ValidationesManagerApp
    {
        public static string MaxAndMinLengthRegister(AuthDto myValue, string language)
        {
            if (myValue.Name.Length < 5 || myValue.Name.Length > 10)
            {
                if (language == "EN")
                {
                    return "The Name must be between 5 and 10 characters";
                }
                else
                {
                    return "El Nombre debe tener entre 5 y 10 caracteres";
                }
            }

            if (myValue.UserName.Length < 5 || myValue.UserName.Length > 10)
            {
                if (language == "EN")
                {
                    return "The username must be between 5 and 10 characters";
                }
                else
                {
                    return "El Nombre del usuario debe tener entre 5 y 10 caracteres";
                }
            }

            if (myValue.Email.Length < 10 || myValue.Email.Length > 50)
            {
                if (language == "EN")
                {
                    return "The email must be between 10 and 50 characters";
                }
                else
                {
                    return "El Correo electrónico debe tener entre 10 y 50 caracteres";
                }
            }

            if (myValue.Password.Length < 5 || myValue.Password.Length > 15)
            {
                if (language == "EN")
                {
                    return "The password must be between 5 and 15 characters";
                }
                else
                {
                    return "La Contraseña debe tener entre 5 y 15 caracteres";
                }
            }
            return "OK";
        }

        public static string MaxAndMinLengthLogin(AuthDto myValue, string language)
        {
            if (string.IsNullOrEmpty(myValue.UserName))
            {
                if (language == "EN")
                {
                    return "The username is required";
                }
                else
                {
                    return "El Usuario es requerido";
                }
            }
            if (string.IsNullOrEmpty(myValue.Password))
            {
                if (language == "EN")
                {
                    return "The password is required";
                }
                else
                {
                    return "La Contraseña es requerida";
                }
            }
            return "OK";
        }
    }
}