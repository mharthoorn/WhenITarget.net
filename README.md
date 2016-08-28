# WhenITarget.net

An interactive site showing which .NET frameworks, TFM's and platforms support eachother

## Problem
This one page site gives an overview of most .NET frameworks and platforms, including .NET core and .netstandard framework moniker.
It allows you to see which platforms you can target and/or which frameworks you support. 

It does so by nested computation, so if you select .netstandard1.0, it will give you a visual representation that you will target 
.netstandard 1.1 upto netstandard 1.6, but also which operating systems (windows, linux, etc.)

