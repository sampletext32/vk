---
layout: default
title: Метод Audio.MoveToAlbum
permalink: audio/moveToAlbum/
comments: true
---
# Метод Audio.MoveToAlbum
Перемещает аудиозаписи в альбом.

Страница документации ВКонтакте [audio.moveToAlbum](https://vk.com/dev/audio.moveToAlbum).
## Синтаксис
``` csharp
public bool MoveToAlbum(long albumId, IEnumerable<long> audioIds, long? groupId = null)
```

## Параметры
+ **groupId** - Идентификатор сообщества, в котором размещены аудиозаписи. Если параметр не указан, работа ведется с аудиозаписями текущего пользователя. положительное число
+ **albumId** - Идентификатор альбома, в который нужно переместить аудиозаписи. положительное число
+ **audioIds** - Идентификаторы аудиозаписей, которые требуется переместить. список положительных чисел, разделенных запятыми, обязательный параметр

## Результат
После успешного выполнения возвращает **true**. 
Обратите внимание, в одном альбоме не может быть более 1000 аудиозаписей.

## Пример
``` csharp
// Пример кода
```

## Версия Вконтакте API v.5.44
Дата обновления: 26.01.2016 19:20:10