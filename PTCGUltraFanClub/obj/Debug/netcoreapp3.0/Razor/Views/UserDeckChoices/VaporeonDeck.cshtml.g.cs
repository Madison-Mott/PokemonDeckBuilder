#pragma checksum "C:\Users\Madis\source\repos\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\VaporeonDeck.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8c33781d255985a7703db8892075e7b04ef4b67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserDeckChoices_VaporeonDeck), @"mvc.1.0.view", @"/Views/UserDeckChoices/VaporeonDeck.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Madis\source\repos\PokemonDeckBuilder\PTCGUltraFanClub\Views\_ViewImports.cshtml"
using PTCGUltraFanClub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Madis\source\repos\PokemonDeckBuilder\PTCGUltraFanClub\Views\_ViewImports.cshtml"
using PTCGUltraFanClub.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c33781d255985a7703db8892075e7b04ef4b67", @"/Views/UserDeckChoices/VaporeonDeck.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b459124555ee9be20d986dd1107e74225c9261e", @"/Views/_ViewImports.cshtml")]
    public class Views_UserDeckChoices_VaporeonDeck : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PTCGUltraFanClub.Models.PokemonCard>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Madis\source\repos\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\VaporeonDeck.cshtml"
  
    ViewData["Title"] = "VaporeonDeck";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"header\">\r\n    <h1>You chose the Vaporeon Deck!</h1>\r\n</div>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 262, "\"", 283, 1);
#nullable restore
#line 14 "C:\Users\Madis\source\repos\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\VaporeonDeck.cshtml"
WriteAttributeValue("", 268, Model.ImageUrl, 268, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 284, "\"", 301, 1);
#nullable restore
#line 14 "C:\Users\Madis\source\repos\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\VaporeonDeck.cshtml"
WriteAttributeValue("", 290, Model.Name, 290, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"col\">\r\n            <h2>Name: ");
#nullable restore
#line 17 "C:\Users\Madis\source\repos\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\VaporeonDeck.cshtml"
                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - HP ");
#nullable restore
#line 17 "C:\Users\Madis\source\repos\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\VaporeonDeck.cshtml"
                                  Write(Model.HP);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n            <p></p>\r\n");
#nullable restore
#line 19 "C:\Users\Madis\source\repos\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\VaporeonDeck.cshtml"
             if (Model.Ability != null)
            {
                Console.WriteLine($"Ability: + {Model.Ability.Text}");
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\r\n                <strong>Attack(s):</strong>\r\n                <br />");
#nullable restore
#line 25 "C:\Users\Madis\source\repos\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\VaporeonDeck.cshtml"
                       for (var i = 0; i < Model.Attacks.Length; i++)
                {
                    var attack = Model.Attacks[i];
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br />\r\n                        <strong>");
#nullable restore
#line 30 "C:\Users\Madis\source\repos\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\VaporeonDeck.cshtml"
                           Write(attack.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> ");
#nullable restore
#line 30 "C:\Users\Madis\source\repos\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\VaporeonDeck.cshtml"
                                                 Write(attack.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <strong>");
#nullable restore
#line 31 "C:\Users\Madis\source\repos\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\VaporeonDeck.cshtml"
                           Write(attack.Damage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                        <br />\r\n                    ");
#nullable restore
#line 33 "C:\Users\Madis\source\repos\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\VaporeonDeck.cshtml"
                           
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n            <p>Evolves From: ");
#nullable restore
#line 36 "C:\Users\Madis\source\repos\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\VaporeonDeck.cshtml"
                        Write(Model.EvolvesFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<br />\r\n\r\n<div>\r\n    ");
#nullable restore
#line 44 "C:\Users\Madis\source\repos\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\VaporeonDeck.cshtml"
Write(Html.ActionLink("See Full Deck", "ReturnFullDeck", "UserDeckChoices"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<style>

    .header {
        padding: 30px;
        border: 2px dashed #1C6EA4;
        text-align: center;
        background: #fff;
        font-family: ""Lucida Console"", Monaco, monospace;
        font-size: 17px;
        letter-spacing: 4px;
        word-spacing: -1px;
        color: #000000;
        font-weight: 400;
        text-decoration: none solid rgb(68, 68, 68);
        font-style: normal;
        font-variant: normal;
        text-transform: none;
    }

</style>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PTCGUltraFanClub.Models.PokemonCard> Html { get; private set; }
    }
}
#pragma warning restore 1591
