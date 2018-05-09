Install-Package Xamarin.Android.Support.v4 -Version 25.4.0.2
Install-Package Xamarin.Android.Support.v7.AppCompat -Version 25.4.0.2
Install-Package Refractored.PagerSlidingTabStrip -Version 1.1.6

右键引用-> 添加Mono.Android.Export.Dll 引用,不引用会报错
注:  
需要install AppCompat 后再 install PagerSlidingTabStrip  . 因为如果先install PagerSlidingTabStrip ,
而PagerSlidingTabStrip依赖了AppCompat >>= 23.4.0 , 如果android sdk 没有23.4.0 .可能会导致联网下载sdk。
因为我采用的sdk 7.1 对于AppCompat 25.4.0.2 是适用的.