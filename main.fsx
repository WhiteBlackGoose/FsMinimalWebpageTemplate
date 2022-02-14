#r "nuget: Giraffe.ViewEngine, 2.0.0-alpha-1"

open Giraffe.ViewEngine

let srcTree = html [] [
    head [] [
        style [] [
            Text """
.some-class {

}
"""
        ]
    ]
    body [] [
        h1 [] [ Text "Hello, world!" ]
        p [] [ Text "Minimal text" ]
        for i in 1..7 do
            p [] [ Text $"{i} aaa" ]
    ]
]

let srcText = RenderView.AsString.htmlNode srcTree

System.IO.File.WriteAllText("./index.html", srcText)
