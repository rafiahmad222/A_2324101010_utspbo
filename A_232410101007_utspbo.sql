PGDMP                  
    |            coba1    16.2    16.2     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    27315    coba1    DATABASE     �   CREATE DATABASE coba1 WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1252';
    DROP DATABASE coba1;
                postgres    false            �            1259    27346 	   mahasiswa    TABLE     }   CREATE TABLE public.mahasiswa (
    id integer NOT NULL,
    nama character varying(50),
    alamat character varying(50)
);
    DROP TABLE public.mahasiswa;
       public         heap    postgres    false            �          0    27346 	   mahasiswa 
   TABLE DATA           5   COPY public.mahasiswa (id, nama, alamat) FROM stdin;
    public          postgres    false    215   Q       P           2606    27350    mahasiswa mahasiswa_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.mahasiswa
    ADD CONSTRAINT mahasiswa_pkey PRIMARY KEY (id);
 B   ALTER TABLE ONLY public.mahasiswa DROP CONSTRAINT mahasiswa_pkey;
       public            postgres    false    215            �   $   x�3�.MO�K�tJ�K)�K�2�t�ʄ�b���� ˙
E     