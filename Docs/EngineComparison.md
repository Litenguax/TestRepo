Across all of these, the only one where placing an object into the scene
or level didn't start with snapping seemed to be Unity. Generally, they
all worked well enough. I could drop just a single 3D model in or I
could add the whole folder (and it was easy enough to add those to the
.gitignore file) and I could drag and drop those assets in at any time.
But they all had different ways of defaulting the drag and drop, with
Unity not favoring a clean drop-in all the time. Overall, when it comes
to building the level, Unity and Unreal are more similar as they can
manually control how much objects snap, though both of them ran into an
issue where the imported 3D models weren't perfectly measured to snap
together, so platforms often needed to be adjusted manually.

I don\'t actually remember if there was a way to parent objects or the
like in Unity, it\'s really not my forte. Prefabs to me aren't really
that great to work with, but blueprint actors felt really similar to
PackedScenes in that there was a more obvious parent-child relationship.

I preferred Unreal if only because a child blueprint takes information a
bit more clearly from the parent and can add in anything else in turn
without affecting the parent.
