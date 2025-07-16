namespace SportProductApp.SportFlow.Order.Enums {
    export enum OrderStatusKind {
        Pending = 0,
        Canceled = 1,
        Completed = 2
    }
    Serenity.Decorators.registerEnumType(OrderStatusKind, 'SportProductApp.SportFlow.Order.Enums.OrderStatusKind', 'SportFlow.OrderStatusKind');
}

