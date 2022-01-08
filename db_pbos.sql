-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 08, 2022 at 01:55 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.2.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_pbos`
--

-- --------------------------------------------------------

--
-- Table structure for table `ms_customer`
--

CREATE TABLE `ms_customer` (
  `id` varchar(10) NOT NULL,
  `nik` varchar(16) NOT NULL,
  `nama` varchar(25) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `jenis_kelamin` varchar(12) NOT NULL,
  `telepon` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ms_customer`
--

INSERT INTO `ms_customer` (`id`, `nik`, `nama`, `alamat`, `jenis_kelamin`, `telepon`) VALUES
('001401', '12121', 'qwqw', '11212kkk', 'P', 121212),
('223817', '456456456', 'hjkhkhkj', 'hjjgjgj', 'L', 565757567);

-- --------------------------------------------------------

--
-- Table structure for table `ms_golongan`
--

CREATE TABLE `ms_golongan` (
  `id_golongan` varchar(10) NOT NULL,
  `nama_golongan` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ms_golongan`
--

INSERT INTO `ms_golongan` (`id_golongan`, `nama_golongan`) VALUES
('GO-110939', 'Food'),
('GO-110947', 'Drink'),
('GO-111021', 'Obat');

-- --------------------------------------------------------

--
-- Table structure for table `ms_jenis_pengeluaran`
--

CREATE TABLE `ms_jenis_pengeluaran` (
  `id_jenis_pengeluaran` varchar(10) NOT NULL,
  `jenis_pengeluaran` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ms_jenis_pengeluaran`
--

INSERT INTO `ms_jenis_pengeluaran` (`id_jenis_pengeluaran`, `jenis_pengeluaran`) VALUES
('225719', 'bagusvvv');

-- --------------------------------------------------------

--
-- Table structure for table `ms_kartu`
--

CREATE TABLE `ms_kartu` (
  `id_kartu` varchar(10) NOT NULL,
  `nama_kartu` varchar(25) NOT NULL,
  `jenis_kartu` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ms_kartu`
--

INSERT INTO `ms_kartu` (`id_kartu`, `nama_kartu`, `jenis_kartu`) VALUES
('CA-104411', 'MASTERCARD', 'Debit');

-- --------------------------------------------------------

--
-- Table structure for table `ms_nota`
--

CREATE TABLE `ms_nota` (
  `id_nota` varchar(10) NOT NULL,
  `header_1` varchar(25) NOT NULL,
  `header_2` varchar(20) NOT NULL,
  `header_3` varchar(20) NOT NULL,
  `footer_1` varchar(25) NOT NULL,
  `footer_2` varchar(25) NOT NULL,
  `footer_3` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `ms_produk`
--

CREATE TABLE `ms_produk` (
  `id_produk` varchar(10) NOT NULL,
  `barcode` varchar(50) NOT NULL,
  `nama_produk` varchar(50) NOT NULL,
  `nama_pendek` varchar(17) NOT NULL,
  `aktif` varchar(1) NOT NULL,
  `id_supplier` varchar(10) NOT NULL,
  `id_golongan` varchar(10) NOT NULL,
  `lokasi` varchar(25) NOT NULL,
  `harga_beli` int(12) NOT NULL,
  `harga_jual` int(12) NOT NULL,
  `stok` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ms_produk`
--

INSERT INTO `ms_produk` (`id_produk`, `barcode`, `nama_produk`, `nama_pendek`, `aktif`, `id_supplier`, `id_golongan`, `lokasi`, `harga_beli`, `harga_jual`, `stok`) VALUES
('111905', '089686180657', 'Indomie Mie Goreng 85g', 'Indomie Grg 85g', 'T', '232717', 'GO-110939', 'Makanan', 2500, 3000, 512),
('113459', '89686010718', 'Indomie Goreng Cabe Ijo 85g', 'Ind Cabe Ijo 85g', 'T', '232717', 'GO-110939', 'Makanan', 2500, 3000, 121);

-- --------------------------------------------------------

--
-- Table structure for table `ms_promo`
--

CREATE TABLE `ms_promo` (
  `id_promo` varchar(10) NOT NULL,
  `nama_promo` varchar(25) NOT NULL,
  `id_produk` varchar(10) NOT NULL,
  `nama_produk` varchar(50) NOT NULL,
  `tgl_awal` date NOT NULL,
  `tgl_akhir` date NOT NULL,
  `harga_promo` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `ms_supplier`
--

CREATE TABLE `ms_supplier` (
  `id_supplier` varchar(10) NOT NULL,
  `nama_supplier` varchar(25) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `telepon` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ms_supplier`
--

INSERT INTO `ms_supplier` (`id_supplier`, `nama_supplier`, `alamat`, `telepon`) VALUES
('SP-143015', 'PT. Sinarmas Jaya', 'Jember', '0812345678'),
('SP-143037', 'PT. Sumber Sentosa Rokok', 'Jember ', '12345678');

-- --------------------------------------------------------

--
-- Table structure for table `ms_toko`
--

CREATE TABLE `ms_toko` (
  `id_toko` varchar(10) NOT NULL,
  `nama_toko` varchar(25) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `kota` varchar(25) NOT NULL,
  `tgl_buka` date NOT NULL,
  `telepon` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ms_toko`
--

INSERT INTO `ms_toko` (`id_toko`, `nama_toko`, `alamat`, `kota`, `tgl_buka`, `telepon`) VALUES
('K153939', 'Aman Jaya', 'Jl. Gebang Timur no.11 A Patrang', 'Jember', '2021-12-01', '081234567891');

-- --------------------------------------------------------

--
-- Table structure for table `ms_user`
--

CREATE TABLE `ms_user` (
  `username` varchar(10) NOT NULL,
  `password` varchar(20) NOT NULL,
  `role` varchar(10) NOT NULL,
  `last_login` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ms_user`
--

INSERT INTO `ms_user` (`username`, `password`, `role`, `last_login`) VALUES
('a', 'a', 'SUPERUSER', '2022-01-08 12:28:32'),
('b', 'b', 'KASIR', '2022-01-08 12:31:24');

-- --------------------------------------------------------

--
-- Table structure for table `tx_pembayaran_pembelian_produk`
--

CREATE TABLE `tx_pembayaran_pembelian_produk` (
  `nota` varchar(12) NOT NULL,
  `id_toko` varchar(10) NOT NULL,
  `tanggal` date NOT NULL,
  `id_supplier` varchar(10) NOT NULL,
  `nota_beli` varchar(12) NOT NULL,
  `rupiah_bayar` int(12) NOT NULL,
  `keterangan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tx_pembayaran_pembelian_produk`
--

INSERT INTO `tx_pembayaran_pembelian_produk` (`nota`, `id_toko`, `tanggal`, `id_supplier`, `nota_beli`, `rupiah_bayar`, `keterangan`) VALUES
('20220104101', 'K153939', '2022-01-04', 'SP-143015', '20220104101', 1250000, '');

-- --------------------------------------------------------

--
-- Table structure for table `tx_pembelian_produk`
--

CREATE TABLE `tx_pembelian_produk` (
  `nota` varchar(12) NOT NULL,
  `id_toko` varchar(10) NOT NULL,
  `tanggal` date NOT NULL,
  `jatuh_tempo` date NOT NULL,
  `status_bayar` varchar(6) NOT NULL,
  `id_supplier` varchar(10) NOT NULL,
  `id_produk` varchar(10) NOT NULL,
  `nama_produk` varchar(50) NOT NULL,
  `qty` int(12) NOT NULL,
  `harga` int(12) NOT NULL,
  `total_harga` int(12) NOT NULL,
  `keterangan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tx_pembelian_produk`
--

INSERT INTO `tx_pembelian_produk` (`nota`, `id_toko`, `tanggal`, `jatuh_tempo`, `status_bayar`, `id_supplier`, `id_produk`, `nama_produk`, `qty`, `harga`, `total_harga`, `keterangan`) VALUES
('20220104101', 'K153939', '2022-01-04', '2022-01-04', 'Tunai', 'SP-143037', '111905', 'Indomie Mie Goreng 85g', 500, 2500, 1250000, ''),
('20220104102', 'K153939', '2022-01-04', '2022-01-31', 'Kredit', 'SP-143037', '113459', 'Indomie Goreng Cabe Ijo 85g', 100, 2500, 250000, ''),
('20220104103', 'K153939', '2022-01-04', '2022-01-31', 'Kredit', 'SP-143015', '111905', 'Indomie Mie Goreng 85g', 1, 2500, 2500, ''),
('20220104103', 'K153939', '2022-01-04', '2022-01-31', 'Kredit', 'SP-143015', '113459', 'Indomie Goreng Cabe Ijo 85g', 1, 2500, 2500, '');

-- --------------------------------------------------------

--
-- Table structure for table `tx_pengeluaran_biaya`
--

CREATE TABLE `tx_pengeluaran_biaya` (
  `nota` int(12) NOT NULL,
  `id_toko` varchar(10) NOT NULL,
  `tanggal` date NOT NULL,
  `jenis_pengeluaran` varchar(50) NOT NULL,
  `qty` int(12) NOT NULL,
  `harga` int(12) NOT NULL,
  `total_harga` int(12) NOT NULL,
  `keterangan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tx_penjualan_det`
--

CREATE TABLE `tx_penjualan_det` (
  `nota` varchar(12) NOT NULL,
  `id_toko` varchar(10) NOT NULL,
  `tanggal` date NOT NULL,
  `jam` time NOT NULL,
  `member` varchar(10) NOT NULL,
  `tipe` varchar(1) NOT NULL,
  `id_produk` varchar(10) NOT NULL,
  `nama_pendek` varchar(17) NOT NULL,
  `qty` int(12) NOT NULL,
  `harga` int(12) NOT NULL,
  `diskon` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tx_penjualan_head`
--

CREATE TABLE `tx_penjualan_head` (
  `nota` varchar(12) NOT NULL,
  `tanggal` date NOT NULL,
  `id_toko` varchar(10) NOT NULL,
  `kasir` varchar(8) NOT NULL,
  `status_bayar` varchar(25) NOT NULL,
  `total_qty` int(12) NOT NULL,
  `total_harga` int(12) NOT NULL,
  `total_diskon` int(12) NOT NULL,
  `bayar` int(12) NOT NULL,
  `kembali` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tx_penyesuaian_stok`
--

CREATE TABLE `tx_penyesuaian_stok` (
  `faktur` varchar(10) NOT NULL,
  `id_toko` varchar(10) NOT NULL,
  `id_produk` varchar(10) NOT NULL,
  `nama_produk` varchar(50) NOT NULL,
  `tgl` date NOT NULL,
  `qty` int(12) NOT NULL,
  `alasan` varchar(25) NOT NULL,
  `keterangan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tx_retur_pembelian`
--

CREATE TABLE `tx_retur_pembelian` (
  `nota` int(12) NOT NULL,
  `id_toko` varchar(10) NOT NULL,
  `tanggal` date NOT NULL,
  `id_supplier` varchar(10) NOT NULL,
  `nota_beli` int(12) NOT NULL,
  `id_produk` varchar(10) NOT NULL,
  `nama_produk` varchar(50) NOT NULL,
  `qty` int(12) NOT NULL,
  `harga` int(12) NOT NULL,
  `total_harga` int(12) NOT NULL,
  `keterangan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tx_stok`
--

CREATE TABLE `tx_stok` (
  `tanggal` date NOT NULL,
  `id_produk` varchar(10) NOT NULL,
  `nama_produk` varchar(50) NOT NULL,
  `harga_beli` int(12) NOT NULL,
  `harga_jual` int(12) NOT NULL,
  `stok_awal` int(12) NOT NULL,
  `receipt` int(12) NOT NULL,
  `sale` int(12) NOT NULL,
  `retur` int(12) NOT NULL,
  `koreksi` int(12) NOT NULL,
  `selisih` int(12) NOT NULL,
  `stok_akhir` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tx_stok`
--

INSERT INTO `tx_stok` (`tanggal`, `id_produk`, `nama_produk`, `harga_beli`, `harga_jual`, `stok_awal`, `receipt`, `sale`, `retur`, `koreksi`, `selisih`, `stok_akhir`) VALUES
('2021-12-11', '111905', 'Indomie Mie Goreng 85g', 2500, 3000, 0, 0, 0, 0, 0, 0, 0),
('2021-12-11', '113459', 'Indomie Goreng Cabe Ijo 85g', 2500, 3000, 0, 0, 0, 0, 0, 0, 0),
('2021-12-13', '111905', 'Indomie Mie Goreng 85g', 2500, 3000, 0, 10, 0, 0, 0, 0, 10),
('2021-12-13', '113459', 'Indomie Goreng Cabe Ijo 85g', 2500, 3000, 0, 20, 0, 0, 0, 0, 20),
('2022-01-03', '111905', 'Indomie Mie Goreng 85g', 2500, 3000, 10, 0, 0, 0, 0, 0, 10),
('2022-01-03', '113459', 'Indomie Goreng Cabe Ijo 85g', 2500, 3000, 20, 0, 0, 0, 0, 0, 20),
('2022-01-04', '111905', 'Indomie Mie Goreng 85g', 2500, 3000, 11, 501, 0, 0, 0, 0, 512),
('2022-01-04', '113459', 'Indomie Goreng Cabe Ijo 85g', 2500, 3000, 20, 101, 0, 0, 0, 0, 121),
('2022-01-08', '111905', 'Indomie Mie Goreng 85g', 2500, 3000, 512, 0, 0, 0, 0, 0, 512),
('2022-01-08', '113459', 'Indomie Goreng Cabe Ijo 85g', 2500, 3000, 121, 0, 0, 0, 0, 0, 121);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `ms_customer`
--
ALTER TABLE `ms_customer`
  ADD PRIMARY KEY (`id`,`nik`) USING BTREE;

--
-- Indexes for table `ms_golongan`
--
ALTER TABLE `ms_golongan`
  ADD PRIMARY KEY (`id_golongan`);

--
-- Indexes for table `ms_jenis_pengeluaran`
--
ALTER TABLE `ms_jenis_pengeluaran`
  ADD PRIMARY KEY (`id_jenis_pengeluaran`);

--
-- Indexes for table `ms_kartu`
--
ALTER TABLE `ms_kartu`
  ADD PRIMARY KEY (`id_kartu`);

--
-- Indexes for table `ms_nota`
--
ALTER TABLE `ms_nota`
  ADD PRIMARY KEY (`id_nota`);

--
-- Indexes for table `ms_produk`
--
ALTER TABLE `ms_produk`
  ADD PRIMARY KEY (`id_produk`,`barcode`) USING BTREE;

--
-- Indexes for table `ms_promo`
--
ALTER TABLE `ms_promo`
  ADD PRIMARY KEY (`id_promo`,`id_produk`) USING BTREE;

--
-- Indexes for table `ms_supplier`
--
ALTER TABLE `ms_supplier`
  ADD PRIMARY KEY (`id_supplier`);

--
-- Indexes for table `ms_toko`
--
ALTER TABLE `ms_toko`
  ADD PRIMARY KEY (`id_toko`);

--
-- Indexes for table `ms_user`
--
ALTER TABLE `ms_user`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `tx_pembayaran_pembelian_produk`
--
ALTER TABLE `tx_pembayaran_pembelian_produk`
  ADD PRIMARY KEY (`nota`,`id_toko`,`tanggal`,`nota_beli`) USING BTREE;

--
-- Indexes for table `tx_pembelian_produk`
--
ALTER TABLE `tx_pembelian_produk`
  ADD PRIMARY KEY (`nota`,`tanggal`,`id_produk`,`id_toko`) USING BTREE;

--
-- Indexes for table `tx_pengeluaran_biaya`
--
ALTER TABLE `tx_pengeluaran_biaya`
  ADD PRIMARY KEY (`nota`,`id_toko`,`tanggal`,`jenis_pengeluaran`) USING BTREE;

--
-- Indexes for table `tx_penjualan_det`
--
ALTER TABLE `tx_penjualan_det`
  ADD PRIMARY KEY (`nota`,`tanggal`,`id_produk`,`id_toko`) USING BTREE;

--
-- Indexes for table `tx_penjualan_head`
--
ALTER TABLE `tx_penjualan_head`
  ADD PRIMARY KEY (`nota`,`tanggal`,`id_toko`) USING BTREE;

--
-- Indexes for table `tx_penyesuaian_stok`
--
ALTER TABLE `tx_penyesuaian_stok`
  ADD PRIMARY KEY (`faktur`,`id_toko`,`id_produk`,`tgl`) USING BTREE;

--
-- Indexes for table `tx_retur_pembelian`
--
ALTER TABLE `tx_retur_pembelian`
  ADD PRIMARY KEY (`nota`,`tanggal`,`id_produk`,`id_toko`) USING BTREE;

--
-- Indexes for table `tx_stok`
--
ALTER TABLE `tx_stok`
  ADD PRIMARY KEY (`tanggal`,`id_produk`) USING BTREE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
