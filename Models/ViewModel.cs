using System.Diagnostics;
using System.Runtime.CompilerServices;
namespace MVCDOTNET.Models;

namespace ConcessionariaMVC {
    public class Carro {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Preco { get; set; }
    }

}
class ErrorViewModel {
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
