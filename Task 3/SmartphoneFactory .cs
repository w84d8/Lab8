public class SmartphoneFactory : ITechnologyFactory
{
    public IScreen CreateScreen() => new SmartphoneScreen();
    public IProcessor CreateProcessor() => new SmartphoneProcessor();
    public ICamera CreateCamera() => new SmartphoneCamera();
}