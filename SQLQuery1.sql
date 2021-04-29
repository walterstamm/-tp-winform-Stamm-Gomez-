use CATALOGO_DB
select * from ARTICULOS
select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, A.ImagenUrl from ARTICULOS A inner join MARCAS M on A.IdMarca = M.Id  inner join CATEGORIAS C on A.IdCategoria = C.Id

select Id, Codigo, Nombre, Descripcion, Precio, ImagenUrl from ARTICULOS

select * from CATEGORIAS
select * from MARCAS



select Id, Nombre, Descripcion, UrlImagen from ARTICU