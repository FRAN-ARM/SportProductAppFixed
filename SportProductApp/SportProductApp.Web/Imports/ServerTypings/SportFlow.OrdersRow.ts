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
        ProvinceId?: number;
        CityId?: number;
    }

    export namespace OrdersRow {
        export const idProperty = 'OrderId';
        export const nameProperty = 'PublicId';
        export const localTextPrefix = 'SportFlow.Orders';
        export const lookupKey = 'SportFlow.OrdersRow';

        export function getLookup(): Q.Lookup<OrdersRow> {
            return Q.getLookup<OrdersRow>('SportFlow.OrdersRow');
        }
        export const deletePermission = 'Customers:General';
        export const insertPermission = 'Customers:General';
        export const readPermission = 'Customers:General';
        export const updatePermission = 'Customers:General';

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
            ItemList = "ItemList",
            ProvinceId = "ProvinceId",
            CityId = "CityId"
        }
    }
}

