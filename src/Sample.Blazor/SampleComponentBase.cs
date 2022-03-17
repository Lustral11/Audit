using Sample.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Sample.Blazor;

public abstract class SampleComponentBase : AbpComponentBase
{
    protected SampleComponentBase()
    {
        LocalizationResource = typeof(SampleResource);
    }
}
