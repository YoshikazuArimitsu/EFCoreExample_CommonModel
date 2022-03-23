# EntityFramework Core モデル共有サンプル 共通モデル側

## 概要

<!-- DIRSTRUCTURE_START_MARKER -->
<pre>
CommonModel/
├─ CommonModelCLI/ .............. モデル/DBコンテキストを参照するコンソールアプリ
└─ CommonModelLib/ .............. モデル/DBコンテキストのライブラリ
</pre>
<!-- DIRSTRUCTURE_END_MARKER -->

* CommonModelLib

  モデルクラス・DBコンテキストとDBマイグレーション履歴を持つプロジェクトです。

* CommonModelCLI

  CommonModelLibを参照する何もしないコンソールアプリケーションです。  
  マイグレーション時、デフォルトでDBを使用するアプリケーションが必要になる為存在します。

## 使用方法

### マイグレーション追加

1. モデルを改修する

2. マイグレーションを追加する

   VisualStudio でスタートアッププロジェクトを CommonModelCLI に設定し、パッケージマネージャコンソールで規定のプロジェクトを CommonModelLib にして、

   ```
   > Add-Migraiton {name}
   ```

   を行うとマイグレーションが追加される。

3. DBを適用する

   ```
   > Update-Database
   ```
   を実行すると、現在のマイグレーションが DB (CommonModelCLIが接続しているDB)に適用される。

### DDL出力

VisualStudio パッケージマネージャコンソールで

```
> Script-Migration
```

を実行すると、現在のDBを作成するSQL文が作成される。
