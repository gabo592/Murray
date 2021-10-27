namespace Murray.Observable
{
    public interface ISujeto
    {
        void Notificar();
        void AgregarObservador(IObservador observador);
    }
}
