# IkinokoBattle

Unity 2021.3.36f1で開発された3Dアクションゲームプロジェクトです。

## 📖 概要

IkinokoBattleは、プレイヤーが敵と戦う3Dアクションゲームです。プレイヤーは移動、ジャンプ、攻撃を行い、定期的にスポーンする敵を倒していきます。

## 🎮 ゲームシステム

### プレイヤー機能
- **移動**: WASDキーで移動
- **ジャンプ**: スペースキーでジャンプ
- **攻撃**: 左クリックで攻撃
- **体力システム**: ダメージを受けると体力が減少

### 敵システム
- **自動スポーン**: プレイヤーの周囲に定期的に敵がスポーン
- **AI移動**: NavMeshを使用した敵の移動
- **攻撃システム**: 敵の攻撃機能
- **体力システム**: 敵も体力を持ち、ダメージを受けると死亡

## 🛠️ 技術仕様

### 使用技術
- **Unity 2021.3.36f1**
- **C#**
- **NavMesh** (敵のAI移動)
- **CharacterController** (プレイヤー移動)
- **Animator** (アニメーション制御)

### 主要パッケージ
- `com.unity.cinemachine`: 2.8.9
- `com.unity.textmeshpro`: 3.0.6
- `com.unity.timeline`: 1.6.5
- `com.unity.visualscripting`: 1.9.1

## 📁 プロジェクト構造

```
Assets/
├── IkinokoBattle/           # メインゲームスクリプト
│   ├── PlayerController.cs   # プレイヤー制御
│   ├── PlayerStatus.cs      # プレイヤー状態管理
│   ├── MobStatus.cs         # 敵の基本状態管理
│   ├── EnemyStatus.cs       # 敵の状態管理
│   ├── EnemyMove.cs         # 敵の移動AI
│   ├── MobAttack.cs         # 攻撃システム
│   ├── Spawner.cs           # 敵スポーンシステム
│   ├── CollisionDetector.cs # 衝突検出
│   ├── RoundLight.cs        # ライト制御
│   ├── Animations/          # アニメーション
│   ├── Materials/           # マテリアル
│   └── Prehabs/            # プレハブ
├── Scenes/
│   └── MainScene/          # メインシーン
└── [各種アセット]          # 地形、エフェクト、モデル等
```

## 🎯 ゲームプレイ

### 操作方法
- **WASD**: 移動
- **スペース**: ジャンプ
- **左クリック**: 攻撃

### ゲーム目標
- スポーンする敵を倒す
- 体力を維持しながら戦闘を続ける
- 可能な限り長く生存する

## 🚀 セットアップ

### 必要な環境
- Unity 2021.3.36f1以上
- Visual Studio 2019/2022 または Visual Studio Code

### インストール手順
1. このリポジトリをクローン
2. Unity Hubでプロジェクトを開く
3. `Assets/Scenes/MainScene.unity`を開く
4. 再生ボタンを押してゲームを開始

## 📝 開発者向け情報

### スクリプト説明

#### PlayerController.cs
プレイヤーの移動、ジャンプ、攻撃を制御するメインスクリプト。

#### MobStatus.cs
敵とプレイヤーの共通状態管理クラス。体力、攻撃状態、死亡状態を管理。

#### Spawner.cs
敵の自動スポーンシステム。プレイヤーの周囲に定期的に敵を生成。

#### EnemyMove.cs
敵のAI移動システム。NavMeshを使用してプレイヤーを追跡。

### カスタマイズ可能なパラメータ
- 移動速度 (`moveSpeed`)
- ジャンプ力 (`jumpPower`)
- 敵のスポーン間隔 (Spawner.cs内の`WaitForSeconds`)
- 敵の体力 (`lifeMax`)

## 🎨 アセット情報

このプロジェクトには以下のアセットが含まれています：
- **Level 1 Monster Pack**: 敵キャラクター（バット、ゴースト、ウサギ、スライム）
- **Conifers [BOTD]**: 植生アセット
- **GrassFlowers**: 草と花のアセット
- **TerrainTexturesPackFree**: 地形テクスチャ
- **Wispy Sky**: スカイボックス
- **#NVJOB Water Shaders V2**: 水エフェクト

## 📄 ライセンス

このプロジェクトは教育目的で作成されています。含まれるアセットのライセンスについては、各アセットのライセンスファイルを参照してください。

## 🤝 貢献

バグ報告や機能提案は歓迎します。プルリクエストも受け付けています。

## 📞 連絡先

プロジェクトに関する質問や提案がある場合は、GitHubのIssues機能をご利用ください。

---

**開発者**: IkinokoBattle Team  
**最終更新**: 2024年 