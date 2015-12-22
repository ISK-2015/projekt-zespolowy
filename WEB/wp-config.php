<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the
 * installation. You don't have to use the web site, you can
 * copy this file to "wp-config.php" and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * MySQL settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://codex.wordpress.org/Editing_wp-config.php
 *
 * @package WordPress
 */

// ** MySQL settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define('DB_NAME', '18659907_0000002');

/** MySQL database username */
define('DB_USER', '18659907_0000002');

/** MySQL database password */
define('DB_PASSWORD', 'pz2-isk1-sggw');

/** MySQL hostname */
define('DB_HOST', 'localhost');

/** Database Charset to use in creating database tables. */
define('DB_CHARSET', 'utf8mb4');

/** The Database Collate type. Don't change this if in doubt. */
define('DB_COLLATE', '');

/**#@+
 * Authentication Unique Keys and Salts.
 *
 * Change these to different unique phrases!
 * You can generate these using the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}
 * You can change these at any point in time to invalidate all existing cookies. This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define('AUTH_KEY',         'r(8u-:0qW~Xc^y4r$P[S+--lZq(I[t-K$z)y5J)r Gu>z6dWQ7Mj^h3;f$89d-i$');
define('SECURE_AUTH_KEY',  '-[LWl08Gu-3B#jQ~_-ULC%ZR62Wo=n&|,$=x;l)cGTWk*m?SSkP|pB|>}i_(Y,=:');
define('LOGGED_IN_KEY',    '7_%(D0AZFNv[ndLVKoZ@g8?u3yzre^;J#JO},LOT>9sEtk(U-1PgOX!*5)Kl $5Y');
define('NONCE_KEY',        'noi#rowywM])`4>$>% ;lbH,m%EL`Z)fCU$e|e-+iOofw=Z| $3IT- ]R?}+GEd&');
define('AUTH_SALT',        '`_XL{)T:82|mm=@,/,|3*s=r+q~ZL2$%9W6]Mp/%|M9S=:BDUStdj;02%~/YM.~V');
define('SECURE_AUTH_SALT', 'VcpHdF}|+^&^4t&-i}+-.yapO!|*%-/A^t/xBq4tj9ehLfaW`+(x|wjtC!Om91K|');
define('LOGGED_IN_SALT',   ',0e|LUmh[0a7hl{RWB(Q=(tO|Qy]VSvk/RIsnQGzYlEllh>C!hpbf:x4+LnvVJ` ');
define('NONCE_SALT',       'e0_!e!?11,mF~Z}3wZqBy5YNJGM|#df8Q,60khi|k+v(0d-?aYc?T(LCNi-[-b|1');

/**#@-*/

/**
 * WordPress Database Table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix  = 'wp_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the Codex.
 *
 * @link https://codex.wordpress.org/Debugging_in_WordPress
 */
define('WP_DEBUG', false);

/* That's all, stop editing! Happy blogging. */

/** Absolute path to the WordPress directory. */
if ( !defined('ABSPATH') )
	define('ABSPATH', dirname(__FILE__) . '/');

/** Sets up WordPress vars and included files. */
require_once(ABSPATH . 'wp-settings.php');
