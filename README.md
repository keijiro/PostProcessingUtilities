Post-Processing Utilities
=========================

This repository contains some utility scripts for [the post-processing stack]
[PostProcessing].

PostProcessingController
------------------------

**PostProcessingController** provides a simple interface to modify the settings
of the post-processing stack -- It exposes all the settings and enabled/disabled
flags as public members. These members can be directly modified from a script or
an animation.

It creates a clone of the profile when starting the Play mode, thus it can
avoid modifying the profile asset on changes. This is similar to
[`Renderer.material`][RendererMaterial] that automatically creates a clone
material on changes.

FocusPuller
-----------

**FocusPuller** automatically updates the focus distance of the depth of field
effect depending on the distance from the camera to a target object.

![gif](https://67.media.tumblr.com/9843254db0c0b00255bb769c93e506e3/tumblr_ogoay0yY0p1qio469o1_320.gif)
![gif](https://66.media.tumblr.com/58b49719b9bdde6c480b8abdba2571ab/tumblr_ogoay0yY0p1qio469o2_320.gif)

It uses PostProcessingController to update the distance dynamically.

[PostProcessing]: https://github.com/Unity-Technologies/PostProcessing
[RendererMaterial]: https://docs.unity3d.com/ScriptReference/Renderer-material.html
