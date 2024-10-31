using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;// librerias para hacer las validaciones
using System.ComponentModel;// librerias para hacer las validaciones

namespace cochinitoDeDulce.Presenters.General
{
    public class ModelDataValidation
    {
        public void Validar(object modelo)
        {
            // resultado de error
            string mensajeError = "";
            // losta para devolver las validaciones
            List<ValidationResult> results = new List<ValidationResult>();
            // contexto pra hacer las validaciones
            ValidationContext context = new ValidationContext(modelo);
            // vemos si es correcta la validacion
            bool isValid = Validator.TryValidateObject(modelo, context, results, true);
            if (isValid == false)
            {
                foreach (var item in results)
                    mensajeError += "- " + item.ErrorMessage + "\n";
                throw new Exception(mensajeError);
            }
        }
    }
}
