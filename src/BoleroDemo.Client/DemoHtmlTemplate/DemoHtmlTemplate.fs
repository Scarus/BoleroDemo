module BoleroDemo.Client.DemoHtmlTemplate

open Bolero

type DemoHtml = Template<"DemoHtmlTemplate/DemoHtmlTemplate.html">

let htmlTemplatePage model dispatch =
    DemoHtml.DemoHtmlTemplate().Elt()