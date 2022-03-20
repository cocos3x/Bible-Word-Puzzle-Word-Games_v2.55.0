# 文件夹含义
UI: 显示层，对应MVC中的View
1. **CommonEffect** : 存放通用特效Prefab。
   如果属于某个弹窗特有的特效，放在Dialog下面相对应弹窗文件夹内部；
2. **CommonItem** : 存放公用的Prefab，非弹窗，弹窗需要放在Dialog相对应的文件夹内；
3. **Dialog** : 存放弹窗Prefab，以及其弹窗所独有的Prefab。
   每个相对应的弹窗需要新建一个子文件夹；   
4. **View** : 存放每个场景所都有的prefab，每个子文件夹对应的Scene名字。
   如果有两个场景上用到，需要放到CommonItem当中；


# 注意：
1. Dialog取名需要注意，Dialog下自文件夹取名 **A** ,则里面必定包含一个**ADialog**用做弹窗的Prefab。
2. Dialog下，每个弹窗所用到的资源需要存放到Art/Sprite/当中。
   如果是其弹窗所独有的资源。需要在Art/Sprite/Dialog/下建立一个同名文件夹存放相关资源。
   如果是有多个弹窗或场景使用，则需要存放到Art/Sprite/Common下；
