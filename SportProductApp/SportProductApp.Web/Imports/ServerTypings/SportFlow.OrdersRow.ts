namespace SportProductApp.SportFlow {
    export interface OrdersRow {
        OrderId?: number;
        PublicId?: string;
        CustomerId?: number;
        Status?: SportFlow.Order.Enums.OrderStatusKind;
        Address?: string;
        DateCreated?: string;
        CustomerPublicId?: string;
        CustomerUserId?: number;
        CustomerName?: string;
        CustomerCreditCard?: string;
        CustomerDateCreated?: string;
        ItemList?: OrderDetailsRow[];
    }

    export namespace OrdersRow {
        export const idProperty = 'OrderId';
        export const nameProperty = 'PublicId';
        export const localTextPrefix = 'SportFlow.Orders';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            OrderId = "OrderId",
            PublicId = "PublicId",
            CustomerId = "CustomerId",
            Status = "Status",
            Address = "Address",
            DateCreated = "DateCreated",
            CustomerPublicId = "CustomerPublicId",
            CustomerUserId = "CustomerUserId",
            CustomerName = "CustomerName",
            CustomerCreditCard = "CustomerCreditCard",
            CustomerDateCreated = "CustomerDateCreated",
            ItemList = "ItemList"
        }
    }
}

