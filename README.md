# CoreLibraries Diagnostics

Библиотека реализует два вида методов проверки состояния приложения в разных вариациях:

- **Check** для проверки входных аргументов public методов.
- **Validate** для проверки состояния переменных внутри метода которые не относятся к входным параметрам.

*Примеры использования **Check**:*

```csharp
     public async Task<T> Method([NotNull] T item)
     {
        // Проверка что входной параметр не null
        Check.NotNull(item, nameof(item));

        // Проверка что свойство входного параметра не null
        Check.NotNull(item.Property, nameof(item), nameof(item.Property));
     }
```

*Пример использования **Validate**:*

```csharp
     public async Task<T> Method([NotNull] T item)
     {
        var itemProperty = item.Property;
        Process(itemProperty);

        // Внутри метода проверяем что переменная не null
        Validate.NotNull(itemProperty, nameof(itemProperty));

        var parsedString = Parse(itemProperty);

        // Внутри метода проверяем что строка не пустая и не null
        // Если так, то возвращаем её.
        return Validate.NotNull(parsedString, nameof(parsedString));
     }
```
