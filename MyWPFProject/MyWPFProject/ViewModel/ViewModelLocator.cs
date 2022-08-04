using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;

namespace MyWPFProject.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<HelloWorldViewModel>();
        }

        public HelloWorldViewModel HelloWorldViewModel => ServiceLocator.Current.GetInstance<HelloWorldViewModel>();
    }
}
