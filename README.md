# Spartan Field
### 제작자 - 백근욱

 <bro>

 # 구성
 Start Scene ━ MainScene ┳ MiniGame2Scene
                         ┗ MiniGameScene

Start 버튼을 통해 MainScene으로 이동
MainScene에서 두명의 NPC를 통해 MiniGamseScene들로 이동

 <bro>
   
# 📂 Unity 구조
```bash
📦SpartaField
 ┣ 📂**Assets**
 ┃ ┣ 📂Animations
 ┃ ┃ ┣ 📂Main
 ┃ ┃ ┃ ┣ 📂NonPlayer
 ┃ ┃ ┃ ┃ ┣ 📜Idle.anim
 ┃ ┃ ┃ ┃ ┣ 📜Idle2.anim
 ┃ ┃ ┃ ┃ ┣ 📜Idle3.anim
 ┃ ┃ ┃ ┃ ┣ 📜MainSprite 1.controller
 ┃ ┃ ┃ ┃ ┣ 📜MainSprite 2.controller
 ┃ ┃ ┃ ┃ ┗ 📜MainSprite.controller
 ┃ ┃ ┃ ┣ 📂Player
 ┃ ┃ ┃ ┃ ┣ 📜Idle.anim
 ┃ ┃ ┃ ┃ ┣ 📜MainSprite.controller
 ┃ ┃ ┃ ┃ ┗ 📜Move.anim
 ┃ ┃ ┗ 📂Mini
 ┃ ┃ ┃ ┃ ┣ 📜Die.anim
 ┃ ┃ ┃ ┃ ┣ 📜flap.anim
 ┃ ┃ ┃ ┃ ┗ 📜Model.controller
 ┃ ┣ 📂 ArkWork
 ┃ ┃ ┣ 📂Level
 ┃ ┃ ┗ 📂tappyplane
 ┃ ┣ 📂 Fonts
 ┃ ┃ ┣ 📜BMHANNA_11yrs_ttf
 ┃ ┃ ┗ 📜BMJUA_ttf
 ┃ ┣ 📂 Images
 ┃ ┃ ┣ 📂frames
 ┃ ┃ ┗ 📂rtan
 ┃ ┣ 📂 PreFabs
 ┃ ┃ ┣ 📜Obstacle.prefab
 ┃ ┃ ┗ 📜TransScene (1).prefab
 ┃ ┣ 📂 Scenes
 ┃ ┃ ┣ 📜MainScene.unity
 ┃ ┃ ┣ 📜MiniGame2Scene.unity
 ┃ ┃ ┗ 📜StartScene.unity
 ┃ ┣ 📂 Scripts
 ┃ ┃ ┣ 📂Button
 ┃ ┃ ┃ ┗ 📜StartButton.cs
 ┃ ┃ ┣ 📂Entity
 ┃ ┃ ┃ ┣ 📜AnimationHandler.cs
 ┃ ┃ ┃ ┣ 📜BaseController.cs
 ┃ ┃ ┃ ┣ 📜DustParticleController.cs
 ┃ ┃ ┃ ┣ 📜MainCameraController.cs
 ┃ ┃ ┃ ┣ 📜NPCController.cs
 ┃ ┃ ┃ ┣ 📜PlayerController.cs
 ┃ ┃ ┃ ┗ 📜TransferScene.cs
 ┃ ┃ ┣ 📂Manager
 ┃ ┃ ┃ ┣ 📜DialogueManager.cs
 ┃ ┃ ┃ ┣ 📜GameManager.cs
 ┃ ┃ ┃ ┣ 📜GameManager2.cs
 ┃ ┃ ┃ ┗ 📜UIManager.cs
 ┗ ┗ ┗ 📂Mini
 ┃ ┃ ┃ ┣ 📜BgLooper.cs
 ┃ ┃ ┃ ┣ 📜FollowCamera.cs
 ┃ ┃ ┃ ┣ 📜MiniPlayer.cs
 ┗ ┗ ┗ ┗ 📜Obstacle.cs
```
