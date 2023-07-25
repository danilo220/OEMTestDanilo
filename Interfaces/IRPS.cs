using OEMTestDanilo.Models.Enums;

namespace OEMTestDanilo.Interfaces
{
    public interface IRPS
    {
        MovePlayed Move { get; }
        void GetMove();
    }
}
