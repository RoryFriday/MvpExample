using StructureMap;
using StructureMap.Pipeline;

namespace MvpExample.Service
{
    public class ServiceLocator
    {
        public static T Get<T>()
        {
            return ObjectFactory.GetInstance<T>();
        }

        public static TPresenter Get<TView, TPresenter>(TView view)
        {
            var args = new ExplicitArguments();
            args.SetArg("view", view);

            return ObjectFactory.GetInstance<TPresenter>(args);
        }
    }
}
