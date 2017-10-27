using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace lulu
{
    class Video
    {
        //优酷视频地址提取
        public string GetYouKu(string url) {
            string pattern = @"[^_]+(?===)";

            Match m = Regex.Match(url, pattern);


            return "http://player.youku.com/embed/" + m.Value;
        }


        //腾讯视频地址提取
        public string GetQq(string url)
        {
            string pattern = @"[^\/]+(?=\.html)";

            Match m = Regex.Match(url, pattern);

            return "https://v.qq.com/iframe/player.html?vid=" + m.Value + "&tiny=0&auto=0";
        }

    }
}
