use CATALOGO_DB
select Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio from ARTICULOS
select isnull(C.Descripcion, 0) as Categorias, A.Id, A.Codigo, A.Nombre, M.Descripcion as Marca ,A.Descripcion, A.Precio, A.ImagenUrl from ARTICULOS A full join MARCAS M on A.IdMarca = M.Id full join CATEGORIAS C on A.IdCategoria = C.Id where A.Id is not null
select Id, Codigo, Nombre, Descripcion, Precio, ImagenUrl from ARTICULOS
select Id, Descripcion from CATEGORIAS
select id, Descripcion from MARCAS
select Id, Nombre, Descripcion, UrlImagen from ARTICULOS

insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (' ', ' ', ' ', 11, 22, ' ', 2.4)

select A.Codigo, A.Nombre, A.Descripcion, M.Descripcion as Marca, A.Precio, A.ImagenUrl, isnull(C.Descripcion, 0) as Categoria  from ARTICULOS A full join MARCAS M on A.IdMarca = M.Id full join CATEGORIAS C on A.IdCategoria = C.Id where A.Id is not null