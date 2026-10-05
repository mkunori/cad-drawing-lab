# CadDrawingLab

C# / Windows Forms / ACadSharp を学習するための個人学習プロジェクトです。

GitHubリポジトリ名は `cad-drawing-lab` です。

## 目的

このプロジェクトでは、Windows Formsで入力した数値をもとにCAD図形を生成し、DWGファイルとして出力する流れを学習します。

主な学習目標は以下です。

- C# / Windows Formsの学習
- Windows Forms Designerを使用した画面作成
- 画面から図形サイズや座標などの数値を入力
- ACadSharpを使用したCAD図形生成
- 2D図形の生成
- 3Dモデルの生成
- DWGファイルへの出力
- DWG TrueViewを起動して生成結果を確認
- UI処理とCAD生成処理の適切な責務分離
- CADで使用する座標や図形データ構造の理解

最終的には、Windows Forms画面から3Dモデルのパラメータを入力し、生成した3DモデルをDWG TrueViewで確認できる状態を目標とします。

## 想定する処理の流れ

```text
Windows Forms
    ↓
数値入力
    ↓
C#モデル / パラメータ
    ↓
座標・形状計算
    ↓
ACadSharp
    ↓
2D / 3D CAD Entity生成
    ↓
DWG出力
    ↓
DWG TrueView
```

## 現在の実装

現在は以下まで実装しています。

- Windows Forms画面から幅・高さを入力
- ボタン押下
- 入力値をもとに矩形を生成
- ACadSharpでDWGファイルを出力
- 出力したDWGを自動的にDWG TrueViewで開く

今後、2D図形の種類を増やした後、3Dモデリングへ進む予定です。

## 開発環境

- Windows
- .NET 10 SDK
- Windows Forms
- Visual Studio
- Visual Studioの「.NET デスクトップ開発」ワークロード
- ACadSharp
- Autodesk DWG TrueView
- Git / GitHub

ターゲットフレームワーク:

```text
net10.0-windows
```

## プロジェクト構成

現時点では、学習しやすさを優先して最小構成としています。

```text
CadDrawingLab.slnx
CadDrawingLab.csproj
Program.cs
Form1.cs
Form1.Designer.cs
Form1.resx
README.md
```

画面はVisual StudioのWindows Forms Designerを使用して作成します。

`Form1.Designer.cs` はDesignerによって管理されるため、原則として直接編集しません。

学習を進めながら、必要に応じてCAD生成処理、ファイル出力処理、外部アプリ起動処理などを別クラスへ分離します。

## ビルド・実行

Visual Studioで `CadDrawingLab.slnx` を開き、F5で実行します。

コマンドラインからビルドする場合:

```powershell
dotnet build CadDrawingLab.slnx
```

## 学習予定

まず2D CAD生成の基本を学び、その後3Dへ進みます。

想定している内容:

```text
数値入力
↓
Line / Circle / Arc
↓
Polyline
↓
Layer
↓
Text / Dimension
↓
Block
↓
XYZ座標
↓
3D図形
↓
3Dモデル
↓
複数部品を組み合わせたモデル
```

3Dでは、まず単純な直方体などから始め、寸法パラメータを変更するとモデル形状が変化する仕組みを作成します。

## 学習方針

アプリケーションの実装は原則として自分で行います。

GitHub上のコードについてはCodexをコードレビュー担当として利用し、レビュー結果や次の実装課題をGitHub Issueとして管理します。

コードレビューでは、単に問題点を指摘するだけでなく、

- なぜ修正するのか
- どのように修正するのか
- 修正例のコード
- 修正後の確認方法

まで含め、C#や設計を学習できる形で進めます。
