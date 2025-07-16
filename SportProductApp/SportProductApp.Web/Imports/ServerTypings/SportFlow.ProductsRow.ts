namespace SportProductApp.SportFlow {
    export interface ProductsRow {
        ProductId?: number;
        PublicId?: string;
        Name?: string;
        Price?: number;
        DateCreated?: string;
    }

    export namespace ProductsRow {
        export const idProperty = 'ProductId';
        export const nameProperty = 'PublicId';
        export const localTextPrefix = 'SportFlow.Products';
        export const lookupKey = 'SportFlow.Products';

        export function getLookup(): Q.Lookup<ProductsRow> {
            return Q.getLookup<ProductsRow>('SportFlow.Products');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            ProductId = "ProductId",
            PublicId = "PublicId",
            Name = "Name",
            Price = "Price",
            DateCreated = "DateCreated"
        }
    }
}

